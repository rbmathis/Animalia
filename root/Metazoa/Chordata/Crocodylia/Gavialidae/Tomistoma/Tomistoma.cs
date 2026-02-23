using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Gavialidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Gavialidae.Tomistoma;

/// <summary>
/// Abstract class for Tomistoma (genus).
/// NCBI TaxId: 184244
/// </summary>
public abstract class Tomistoma : Gavialidae, ITomistoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tomistoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184244;

    /// <inheritdoc />
    public virtual string GenusName => "Tomistoma";

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
