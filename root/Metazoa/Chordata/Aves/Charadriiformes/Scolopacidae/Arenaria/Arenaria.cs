using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Arenaria;

/// <summary>
/// Abstract class for Arenaria (genus).
/// NCBI TaxId: 54972
/// </summary>
public abstract class Arenaria : Scolopacidae, IArenaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arenaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54972;

    /// <inheritdoc />
    public virtual string GenusName => "Arenaria";

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
