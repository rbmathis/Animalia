using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Phenacobrycon;

/// <summary>
/// Abstract class for Phenacobrycon (genus).
/// NCBI TaxId: 2608189
/// </summary>
public abstract class Phenacobrycon : Stevardiidae, IPhenacobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phenacobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608189;

    /// <inheritdoc />
    public virtual string GenusName => "Phenacobrycon";

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
