using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Gymnocichla;

/// <summary>
/// Abstract class for Gymnocichla (genus).
/// NCBI TaxId: 288101
/// </summary>
public abstract class Gymnocichla : Thamnophilidae, IGymnocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288101;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnocichla";

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
