using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Kanekonia;

/// <summary>
/// Abstract class for Kanekonia (genus).
/// NCBI TaxId: 1680626
/// </summary>
public abstract class Kanekonia : Aploactinidae, IKanekonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kanekonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1680626;

    /// <inheritdoc />
    public virtual string GenusName => "Kanekonia";

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
