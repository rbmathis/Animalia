using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Dibranchus;

/// <summary>
/// Abstract class for Dibranchus (genus).
/// NCBI TaxId: 242975
/// </summary>
public abstract class Dibranchus : Ogcocephalidae, IDibranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dibranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242975;

    /// <inheritdoc />
    public virtual string GenusName => "Dibranchus";

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
