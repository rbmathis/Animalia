using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Aploactis;

/// <summary>
/// Abstract class for Aploactis (genus).
/// NCBI TaxId: 1609598
/// </summary>
public abstract class Aploactis : Aploactinidae, IAploactis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aploactis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1609598;

    /// <inheritdoc />
    public virtual string GenusName => "Aploactis";

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
