using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Gavialidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Gavialidae.Gavialis;

/// <summary>
/// Abstract class for Gavialis (genus).
/// NCBI TaxId: 94834
/// </summary>
public abstract class Gavialis : Gavialidae, IGavialis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gavialis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94834;

    /// <inheritdoc />
    public virtual string GenusName => "Gavialis";

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
