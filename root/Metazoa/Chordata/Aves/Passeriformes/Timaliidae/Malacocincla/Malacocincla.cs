using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Malacocincla;

/// <summary>
/// Abstract class for Malacocincla (genus).
/// NCBI TaxId: 201340
/// </summary>
public abstract class Malacocincla : Timaliidae, IMalacocincla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacocincla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201340;

    /// <inheritdoc />
    public virtual string GenusName => "Malacocincla";

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
