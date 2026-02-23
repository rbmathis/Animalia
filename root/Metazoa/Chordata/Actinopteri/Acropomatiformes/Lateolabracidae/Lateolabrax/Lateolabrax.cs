using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Lateolabracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Lateolabracidae.Lateolabrax;

/// <summary>
/// Abstract class for Lateolabrax (genus).
/// NCBI TaxId: 8163
/// </summary>
public abstract class Lateolabrax : Lateolabracidae, ILateolabrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lateolabrax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8163;

    /// <inheritdoc />
    public virtual string GenusName => "Lateolabrax";

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
