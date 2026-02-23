using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Lampropsar;

/// <summary>
/// Abstract class for Lampropsar (genus).
/// NCBI TaxId: 84806
/// </summary>
public abstract class Lampropsar : Icteridae, ILampropsar
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lampropsar";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84806;

    /// <inheritdoc />
    public virtual string GenusName => "Lampropsar";

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
