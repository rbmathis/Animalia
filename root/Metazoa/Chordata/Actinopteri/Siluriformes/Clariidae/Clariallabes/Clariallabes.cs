using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clariallabes;

/// <summary>
/// Abstract class for Clariallabes (genus).
/// NCBI TaxId: 310922
/// </summary>
public abstract class Clariallabes : Clariidae, IClariallabes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clariallabes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 310922;

    /// <inheritdoc />
    public virtual string GenusName => "Clariallabes";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
