using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Neoaploactis;

/// <summary>
/// Abstract class for Neoaploactis (genus).
/// NCBI TaxId: 2961592
/// </summary>
public abstract class Neoaploactis : Aploactinidae, INeoaploactis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoaploactis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2961592;

    /// <inheritdoc />
    public virtual string GenusName => "Neoaploactis";

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
