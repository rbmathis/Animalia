using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Synthliboramphus;

/// <summary>
/// Abstract class for Synthliboramphus (genus).
/// NCBI TaxId: 28707
/// </summary>
public abstract class Synthliboramphus : Alcidae, ISynthliboramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synthliboramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28707;

    /// <inheritdoc />
    public virtual string GenusName => "Synthliboramphus";

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
