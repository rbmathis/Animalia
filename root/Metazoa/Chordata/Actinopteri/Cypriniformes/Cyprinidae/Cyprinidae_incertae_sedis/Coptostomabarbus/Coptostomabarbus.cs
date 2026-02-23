using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinidae_incertae_sedis.Coptostomabarbus;

/// <summary>
/// Abstract class for Coptostomabarbus (genus).
/// NCBI TaxId: 1772066
/// </summary>
public abstract class Coptostomabarbus : Cyprinidae_incertae_sedis, ICoptostomabarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coptostomabarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1772066;

    /// <inheritdoc />
    public virtual string GenusName => "Coptostomabarbus";

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
