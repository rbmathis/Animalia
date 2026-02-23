using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Myiopsitta;

/// <summary>
/// Abstract class for Myiopsitta (genus).
/// NCBI TaxId: 176065
/// </summary>
public abstract class Myiopsitta : Psittacidae, IMyiopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176065;

    /// <inheritdoc />
    public virtual string GenusName => "Myiopsitta";

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
