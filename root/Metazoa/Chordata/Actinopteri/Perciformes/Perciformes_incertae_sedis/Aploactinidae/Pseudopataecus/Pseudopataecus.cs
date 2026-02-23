using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Pseudopataecus;

/// <summary>
/// Abstract class for Pseudopataecus (genus).
/// NCBI TaxId: 2578405
/// </summary>
public abstract class Pseudopataecus : Aploactinidae, IPseudopataecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudopataecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578405;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudopataecus";

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
