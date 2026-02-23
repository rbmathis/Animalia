using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Pteridophora;

/// <summary>
/// Abstract class for Pteridophora (genus).
/// NCBI TaxId: 681205
/// </summary>
public abstract class Pteridophora : Paradisaeidae, IPteridophora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteridophora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681205;

    /// <inheritdoc />
    public virtual string GenusName => "Pteridophora";

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
