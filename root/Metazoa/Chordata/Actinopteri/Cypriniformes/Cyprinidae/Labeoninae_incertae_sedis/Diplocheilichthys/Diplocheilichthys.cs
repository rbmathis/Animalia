using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis.Diplocheilichthys;

/// <summary>
/// Abstract class for Diplocheilichthys (genus).
/// NCBI TaxId: 2518937
/// </summary>
public abstract class Diplocheilichthys : Labeoninae_incertae_sedis, IDiplocheilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplocheilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2518937;

    /// <inheritdoc />
    public virtual string GenusName => "Diplocheilichthys";

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
