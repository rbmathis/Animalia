using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Anchariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Anchariidae.Gogo;

/// <summary>
/// Abstract class for Gogo (genus).
/// NCBI TaxId: 390446
/// </summary>
public abstract class Gogo : Anchariidae, IGogo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gogo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390446;

    /// <inheritdoc />
    public virtual string GenusName => "Gogo";

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
