using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Rasbora;

/// <summary>
/// Abstract class for Rasbora (genus).
/// NCBI TaxId: 27710
/// </summary>
public abstract class Rasbora : Danionidae, IRasbora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rasbora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27710;

    /// <inheritdoc />
    public virtual string GenusName => "Rasbora";

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
