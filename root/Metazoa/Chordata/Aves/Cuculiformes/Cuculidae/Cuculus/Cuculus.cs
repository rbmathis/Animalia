using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Cuculus;

/// <summary>
/// Abstract class for Cuculus (genus).
/// NCBI TaxId: 33592
/// </summary>
public abstract class Cuculus : Cuculidae, ICuculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cuculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33592;

    /// <inheritdoc />
    public virtual string GenusName => "Cuculus";

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
