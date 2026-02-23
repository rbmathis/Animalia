using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Dolichallabes;

/// <summary>
/// Abstract class for Dolichallabes (genus).
/// NCBI TaxId: 1071672
/// </summary>
public abstract class Dolichallabes : Clariidae, IDolichallabes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dolichallabes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1071672;

    /// <inheritdoc />
    public virtual string GenusName => "Dolichallabes";

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
