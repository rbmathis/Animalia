using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Mohoua;

/// <summary>
/// Abstract class for Mohoua (genus).
/// NCBI TaxId: 626426
/// </summary>
public abstract class Mohoua : Acanthizidae, IMohoua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mohoua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 626426;

    /// <inheritdoc />
    public virtual string GenusName => "Mohoua";

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
