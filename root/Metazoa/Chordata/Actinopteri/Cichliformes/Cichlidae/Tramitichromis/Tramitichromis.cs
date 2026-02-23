using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tramitichromis;

/// <summary>
/// Abstract class for Tramitichromis (genus).
/// NCBI TaxId: 136859
/// </summary>
public abstract class Tramitichromis : Cichlidae, ITramitichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tramitichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 136859;

    /// <inheritdoc />
    public virtual string GenusName => "Tramitichromis";

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
