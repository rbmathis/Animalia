using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Cyanopsitta;

/// <summary>
/// Abstract class for Cyanopsitta (genus).
/// NCBI TaxId: 51901
/// </summary>
public abstract class Cyanopsitta : Psittacidae, ICyanopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51901;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanopsitta";

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
