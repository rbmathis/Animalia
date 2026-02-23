using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Kaupifalco;

/// <summary>
/// Abstract class for Kaupifalco (genus).
/// NCBI TaxId: 223779
/// </summary>
public abstract class Kaupifalco : Accipitridae, IKaupifalco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kaupifalco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223779;

    /// <inheritdoc />
    public virtual string GenusName => "Kaupifalco";

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
