using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Cathartidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Cathartidae.Sarcoramphus;

/// <summary>
/// Abstract class for Sarcoramphus (genus).
/// NCBI TaxId: 43582
/// </summary>
public abstract class Sarcoramphus : Cathartidae, ISarcoramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarcoramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43582;

    /// <inheritdoc />
    public virtual string GenusName => "Sarcoramphus";

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
