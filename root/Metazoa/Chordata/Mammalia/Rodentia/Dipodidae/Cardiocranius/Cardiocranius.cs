using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Cardiocranius;

/// <summary>
/// Abstract class for Cardiocranius (genus).
/// NCBI TaxId: 1041410
/// </summary>
public abstract class Cardiocranius : Dipodidae, ICardiocranius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cardiocranius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1041410;

    /// <inheritdoc />
    public virtual string GenusName => "Cardiocranius";

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
