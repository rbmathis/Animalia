using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Melampitta;

/// <summary>
/// Abstract class for Melampitta (genus).
/// NCBI TaxId: 156161
/// </summary>
public abstract class Melampitta : Corvidae, IMelampitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melampitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156161;

    /// <inheritdoc />
    public virtual string GenusName => "Melampitta";

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
