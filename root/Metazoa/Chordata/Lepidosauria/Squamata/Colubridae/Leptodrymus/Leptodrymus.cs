using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Leptodrymus;

/// <summary>
/// Abstract class for Leptodrymus (genus).
/// NCBI TaxId: 1545007
/// </summary>
public abstract class Leptodrymus : Colubridae, ILeptodrymus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptodrymus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545007;

    /// <inheritdoc />
    public virtual string GenusName => "Leptodrymus";

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
