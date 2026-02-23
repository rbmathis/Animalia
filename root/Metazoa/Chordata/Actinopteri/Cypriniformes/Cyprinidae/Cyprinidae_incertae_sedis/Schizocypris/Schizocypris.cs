using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinidae_incertae_sedis.Schizocypris;

/// <summary>
/// Abstract class for Schizocypris (genus).
/// NCBI TaxId: 1114944
/// </summary>
public abstract class Schizocypris : Cyprinidae_incertae_sedis, ISchizocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schizocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1114944;

    /// <inheritdoc />
    public virtual string GenusName => "Schizocypris";

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
