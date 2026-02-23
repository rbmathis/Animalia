using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Cacomantis;

/// <summary>
/// Abstract class for Cacomantis (genus).
/// NCBI TaxId: 55664
/// </summary>
public abstract class Cacomantis : Cuculidae, ICacomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cacomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55664;

    /// <inheritdoc />
    public virtual string GenusName => "Cacomantis";

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
