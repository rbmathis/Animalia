using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Foulehaio;

/// <summary>
/// Abstract class for Foulehaio (genus).
/// NCBI TaxId: 266355
/// </summary>
public abstract class Foulehaio : Meliphagidae, IFoulehaio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Foulehaio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266355;

    /// <inheritdoc />
    public virtual string GenusName => "Foulehaio";

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
