using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Neosebastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Neosebastidae.Neosebastes;

/// <summary>
/// Abstract class for Neosebastes (genus).
/// NCBI TaxId: 334943
/// </summary>
public abstract class Neosebastes : Neosebastidae, INeosebastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neosebastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334943;

    /// <inheritdoc />
    public virtual string GenusName => "Neosebastes";

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
