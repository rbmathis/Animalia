using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Achaetops;

/// <summary>
/// Abstract class for Achaetops (genus).
/// NCBI TaxId: 315539
/// </summary>
public abstract class Achaetops : Sylviidae, IAchaetops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Achaetops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315539;

    /// <inheritdoc />
    public virtual string GenusName => "Achaetops";

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
