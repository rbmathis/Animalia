using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Manouria;

/// <summary>
/// Abstract class for Manouria (genus).
/// NCBI TaxId: 74923
/// </summary>
public abstract class Manouria : Testudinidae, IManouria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Manouria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74923;

    /// <inheritdoc />
    public virtual string GenusName => "Manouria";

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
