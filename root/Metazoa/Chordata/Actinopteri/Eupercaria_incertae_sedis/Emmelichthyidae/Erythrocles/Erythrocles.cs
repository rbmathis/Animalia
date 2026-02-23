using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae.Erythrocles;

/// <summary>
/// Abstract class for Erythrocles (genus).
/// NCBI TaxId: 390329
/// </summary>
public abstract class Erythrocles : Emmelichthyidae, IErythrocles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythrocles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390329;

    /// <inheritdoc />
    public virtual string GenusName => "Erythrocles";

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
