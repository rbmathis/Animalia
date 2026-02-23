using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Potoroidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Potoroidae.Caloprymnus;

/// <summary>
/// Abstract class for Caloprymnus (genus).
/// NCBI TaxId: 223566
/// </summary>
public abstract class Caloprymnus : Potoroidae, ICaloprymnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caloprymnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223566;

    /// <inheritdoc />
    public virtual string GenusName => "Caloprymnus";

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
