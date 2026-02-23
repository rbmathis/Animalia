using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Emydocephalus;

/// <summary>
/// Abstract class for Emydocephalus (genus).
/// NCBI TaxId: 34995
/// </summary>
public abstract class Emydocephalus : Elapidae, IEmydocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emydocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34995;

    /// <inheritdoc />
    public virtual string GenusName => "Emydocephalus";

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
