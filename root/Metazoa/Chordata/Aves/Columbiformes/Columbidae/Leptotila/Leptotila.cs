using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Leptotila;

/// <summary>
/// Abstract class for Leptotila (genus).
/// NCBI TaxId: 115655
/// </summary>
public abstract class Leptotila : Columbidae, ILeptotila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptotila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115655;

    /// <inheritdoc />
    public virtual string GenusName => "Leptotila";

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
