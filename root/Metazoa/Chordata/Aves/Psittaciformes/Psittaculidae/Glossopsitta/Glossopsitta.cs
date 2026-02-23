using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Glossopsitta;

/// <summary>
/// Abstract class for Glossopsitta (genus).
/// NCBI TaxId: 176040
/// </summary>
public abstract class Glossopsitta : Psittaculidae, IGlossopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glossopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176040;

    /// <inheritdoc />
    public virtual string GenusName => "Glossopsitta";

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
