using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinidae_incertae_sedis.Chagunius;

/// <summary>
/// Abstract class for Chagunius (genus).
/// NCBI TaxId: 643436
/// </summary>
public abstract class Chagunius : Cyprinidae_incertae_sedis, IChagunius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chagunius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643436;

    /// <inheritdoc />
    public virtual string GenusName => "Chagunius";

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
