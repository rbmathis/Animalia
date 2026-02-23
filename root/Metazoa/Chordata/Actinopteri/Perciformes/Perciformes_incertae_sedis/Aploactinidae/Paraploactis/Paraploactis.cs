using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Paraploactis;

/// <summary>
/// Abstract class for Paraploactis (genus).
/// NCBI TaxId: 1609596
/// </summary>
public abstract class Paraploactis : Aploactinidae, IParaploactis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraploactis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1609596;

    /// <inheritdoc />
    public virtual string GenusName => "Paraploactis";

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
