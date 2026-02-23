using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobionidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobionidae_incertae_sedis.Paraleucogobio;

/// <summary>
/// Abstract class for Paraleucogobio (genus).
/// NCBI TaxId: 328530
/// </summary>
public abstract class Paraleucogobio : Gobionidae_incertae_sedis, IParaleucogobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraleucogobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 328530;

    /// <inheritdoc />
    public virtual string GenusName => "Paraleucogobio";

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
