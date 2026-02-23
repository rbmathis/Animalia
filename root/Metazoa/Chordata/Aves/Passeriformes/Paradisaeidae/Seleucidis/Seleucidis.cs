using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Seleucidis;

/// <summary>
/// Abstract class for Seleucidis (genus).
/// NCBI TaxId: 36264
/// </summary>
public abstract class Seleucidis : Paradisaeidae, ISeleucidis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Seleucidis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36264;

    /// <inheritdoc />
    public virtual string GenusName => "Seleucidis";

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
