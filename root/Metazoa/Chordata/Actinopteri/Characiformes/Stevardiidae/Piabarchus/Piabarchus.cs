using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Piabarchus;

/// <summary>
/// Abstract class for Piabarchus (genus).
/// NCBI TaxId: 930370
/// </summary>
public abstract class Piabarchus : Stevardiidae, IPiabarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Piabarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930370;

    /// <inheritdoc />
    public virtual string GenusName => "Piabarchus";

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
