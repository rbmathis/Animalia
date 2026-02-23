using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Lepthoplosternum;

/// <summary>
/// Abstract class for Lepthoplosternum (genus).
/// NCBI TaxId: 245779
/// </summary>
public abstract class Lepthoplosternum : Callichthyidae, ILepthoplosternum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepthoplosternum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245779;

    /// <inheritdoc />
    public virtual string GenusName => "Lepthoplosternum";

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
