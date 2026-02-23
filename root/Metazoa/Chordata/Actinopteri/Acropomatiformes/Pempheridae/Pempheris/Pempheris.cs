using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pempheridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pempheridae.Pempheris;

/// <summary>
/// Abstract class for Pempheris (genus).
/// NCBI TaxId: 463599
/// </summary>
public abstract class Pempheris : Pempheridae, IPempheris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pempheris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 463599;

    /// <inheritdoc />
    public virtual string GenusName => "Pempheris";

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
