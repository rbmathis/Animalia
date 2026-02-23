using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae.Emmelichthys;

/// <summary>
/// Abstract class for Emmelichthys (genus).
/// NCBI TaxId: 181463
/// </summary>
public abstract class Emmelichthys : Emmelichthyidae, IEmmelichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emmelichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181463;

    /// <inheritdoc />
    public virtual string GenusName => "Emmelichthys";

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
