using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Alluaudina;

/// <summary>
/// Abstract class for Alluaudina (genus).
/// NCBI TaxId: 224538
/// </summary>
public abstract class Alluaudina : Lamprophiidae, IAlluaudina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alluaudina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224538;

    /// <inheritdoc />
    public virtual string GenusName => "Alluaudina";

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
