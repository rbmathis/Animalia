using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Sarcops;

/// <summary>
/// Abstract class for Sarcops (genus).
/// NCBI TaxId: 245066
/// </summary>
public abstract class Sarcops : Sturnidae, ISarcops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarcops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245066;

    /// <inheritdoc />
    public virtual string GenusName => "Sarcops";

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
