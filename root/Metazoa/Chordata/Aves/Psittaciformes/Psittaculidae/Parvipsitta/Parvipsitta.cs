using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Parvipsitta;

/// <summary>
/// Abstract class for Parvipsitta (genus).
/// NCBI TaxId: 2823049
/// </summary>
public abstract class Parvipsitta : Psittaculidae, IParvipsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parvipsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823049;

    /// <inheritdoc />
    public virtual string GenusName => "Parvipsitta";

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
