using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ptychochromis;

/// <summary>
/// Abstract class for Ptychochromis (genus).
/// NCBI TaxId: 96999
/// </summary>
public abstract class Ptychochromis : Cichlidae, IPtychochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptychochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96999;

    /// <inheritdoc />
    public virtual string GenusName => "Ptychochromis";

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
