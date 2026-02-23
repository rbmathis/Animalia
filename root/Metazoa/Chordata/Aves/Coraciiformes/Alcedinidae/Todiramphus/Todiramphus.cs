using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Todiramphus;

/// <summary>
/// Abstract class for Todiramphus (genus).
/// NCBI TaxId: 325346
/// </summary>
public abstract class Todiramphus : Alcedinidae, ITodiramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Todiramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 325346;

    /// <inheritdoc />
    public virtual string GenusName => "Todiramphus";

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
