using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Discoglossus;

/// <summary>
/// Abstract class for Discoglossus (genus).
/// NCBI TaxId: 8350
/// </summary>
public abstract class Discoglossus : Alytidae, IDiscoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Discoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8350;

    /// <inheritdoc />
    public virtual string GenusName => "Discoglossus";

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
