using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Pataecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Pataecidae.Pataecus;

/// <summary>
/// Abstract class for Pataecus (genus).
/// NCBI TaxId: 2291622
/// </summary>
public abstract class Pataecus : Pataecidae, IPataecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pataecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2291622;

    /// <inheritdoc />
    public virtual string GenusName => "Pataecus";

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
