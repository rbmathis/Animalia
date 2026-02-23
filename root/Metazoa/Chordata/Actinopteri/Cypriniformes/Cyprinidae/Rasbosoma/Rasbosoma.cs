using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Rasbosoma;

/// <summary>
/// Abstract class for Rasbosoma (genus).
/// NCBI TaxId: 3362312
/// </summary>
public abstract class Rasbosoma : Cyprinidae, IRasbosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rasbosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362312;

    /// <inheritdoc />
    public virtual string GenusName => "Rasbosoma";

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
