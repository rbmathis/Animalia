using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Leiocephalus;

/// <summary>
/// Abstract class for Leiocephalus (genus).
/// NCBI TaxId: 38931
/// </summary>
public abstract class Leiocephalus : Iguanidae, ILeiocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38931;

    /// <inheritdoc />
    public virtual string GenusName => "Leiocephalus";

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
