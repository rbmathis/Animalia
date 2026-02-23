using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinidae_incertae_sedis.Caecobarbus;

/// <summary>
/// Abstract class for Caecobarbus (genus).
/// NCBI TaxId: 2135405
/// </summary>
public abstract class Caecobarbus : Cyprinidae_incertae_sedis, ICaecobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caecobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2135405;

    /// <inheritdoc />
    public virtual string GenusName => "Caecobarbus";

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
