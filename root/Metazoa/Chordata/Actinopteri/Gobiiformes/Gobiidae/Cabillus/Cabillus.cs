using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cabillus;

/// <summary>
/// Abstract class for Cabillus (genus).
/// NCBI TaxId: 166736
/// </summary>
public abstract class Cabillus : Gobiidae, ICabillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cabillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166736;

    /// <inheritdoc />
    public virtual string GenusName => "Cabillus";

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
