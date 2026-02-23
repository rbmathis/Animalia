using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Kamoharaia;

/// <summary>
/// Abstract class for Kamoharaia (genus).
/// NCBI TaxId: 366901
/// </summary>
public abstract class Kamoharaia : Bothidae, IKamoharaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kamoharaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 366901;

    /// <inheritdoc />
    public virtual string GenusName => "Kamoharaia";

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
